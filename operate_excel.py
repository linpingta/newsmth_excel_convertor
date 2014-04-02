# -*- coding: UTF-8 -*-

import xlwt,xlrd
from xlutils.copy import copy
import codecs
from datetime import datetime
import MySQLdb
import sys
import time

class excel_necessity_info:
    # need info
    # title,desc,color_list,size_list,url_list,key_word_list,price
    def __init__(self,title,desc1,price,keyword_list,color_list,size_list,url_list,reprice):
        self.title = title
        self.desc1 = desc1
        self.price = price
        self.keyword_list = keyword_list
        self.color_list = color_list
        self.size_list = size_list
        self.url_list = url_list
        self.reprice = reprice

    def __str__(self):
        return self.title
        
def transfer_txt_to_excel(output_filename,template_type):
    print output_filename
    
    # read databse
    excel_necessity_info_list = []
    try:
        conn=MySQLdb.connect(host='localhost',user='root',passwd='root1',charset='utf8',port=3306)
        conn.set_character_set('utf8')
        cur=conn.cursor()
        
        conn.select_db('smth_linpingta')
        cur.execute('SET NAMES utf8;')
        cur.execute('SET CHARACTER SET utf8;')
        cur.execute('SET character_set_connection=utf8;')
        
        cur.execute('select TITLE, DESC1, PRICE, KEYWORDS, COLORLIST, SIZELIST, URLLIST, REPRICE from smth_linpingta.smth2')
            
        count = 1
        for row in cur.fetchall():
            title = row[0]
            desc1 = row[1]
            price = row[2]
            keyword_list = row[3].split(',')
            color_list = row[4].split(',')
            size_list = row[5].split(',')
            url_list = row[6].split(',')
            reprice = row[7]
            
            #excel_item = excel_necessity_info(title,desc1,price,keyword_list,color_list,size_list,url_list,reprice)
            excel_necessity_info_list.append(excel_necessity_info(title,desc1,price,keyword_list,color_list,size_list,url_list,reprice))
            
            #print '\n'
            #if count > 0:
            #    break
            #count = count + 1
        
    except MySQLdb.Error,e:
        print "Install Mysql First"
        print e
        
    # read excel
    
    rb = xlrd.open_workbook(output_filename, on_demand=True, formatting_info=True)
    my_sheet = rb.sheet_by_name(u'模板')
    ncols = my_sheet.ncols
    item_list = my_sheet.row_values(1)
    for item in item_list:
        #print item
        if template_type < 4 and item.strip() == u'限时折扣价':
            reprice_index = item_list.index(item)
            break
        elif template_type >= 4 and item.strip() == u'特价':
            #print 'am i here'
            reprice_index = item_list.index(item)
            break
        else:
            reprice_index = -1

    title_index = item_list.index(u'商品名称')
    desc1_index = item_list.index(u'描述')
    price_index = item_list.index(u'商品价格')
    #reprice_index = item_list.index(u'限时折扣价\n')
    
    #print title_index,desc1_index,price_index,reprice_index
    
    if template_type == 1 or template_type == 2:
        keyword_first_index = item_list.index(u'搜索关键词1')
    elif template_type == 3:
        keyword_first_index = item_list.index(u'搜索关键词 11')
    elif template_type == 4:
        keyword_first_index = item_list.index(u'搜索关键词')
    elif template_type == 5:
        keyword_first_index = item_list.index(u'搜索关键词 1 - 搜索关键词51')
    else:
        keyword_first_index = -1
        
    url_first_index = item_list.index(u'主图片 URL')
    
    if template_type != 2:
        var_index = item_list.index(u'商品变体主题')
        parent_child_index = item_list.index(u'父子关系')
        relation_type_index = item_list.index(u'关系类型')
        parent_SKU_index = item_list.index(u'父 SKU')
        #print parent_SKU_index
    SKU_index = item_list.index(u'SKU')
    
    color_index = item_list.index(u'颜色')
    size_index = item_list.index(u'尺寸')

    start_time_index = item_list.index(u'限时折扣价开始日期\n')
    end_time_index = item_list.index(u'限时折扣价结束日期')
    money_index = item_list.index(u'货币')
    store_index = item_list.index(u'库存数量')
    colorer_index = item_list.index(u'色卡')
    
    wb = copy(rb)
    ws = wb.get_sheet(3)
    index = 3
    parent_index = 3
    for excel_necessity_item in excel_necessity_info_list:        
        # add other info for line2 to linen
        if title_index > -1:
            ws.write(index, title_index, excel_necessity_item.title)
        if desc1_index > -1:
            ws.write(index, desc1_index, excel_necessity_item.desc1)
        #if price_index > -1:
        #    ws.write(index, price_index, excel_necessity_item.price)
        #if reprice_index > -1:
        #    ws.write(index, reprice_index, excel_necessity_item.reprice)
        
        # generate pesudo code
        time_str = int(time.time())
        #print time_str
        sku_str = 'SMTH' + str(parent_index - 1) + str(time_str)
        if SKU_index > -1:
            ws.write(index, SKU_index, sku_str)
        
        parent_type = u''
        color_size_flag = False
        color_exist = False
        for color in excel_necessity_item.color_list:
            for size in excel_necessity_item.size_list:
                if len(color) > 0 or len(size) > 0:
                    color_size_flag = True  					
                if len(color) > 0 and len(size) > 0:
                    parent_type = u'尺寸颜色'
					#color_exist = True
                    break
                elif len(color) > 0:
                    parent_type = u'颜色'
                    color_exist = True
                elif len(size) > 0:
                    parent_type = u'尺寸'            
                
        if parent_type != u'':
            ws.write(index, var_index, parent_type)
        
        #print color_size_flag
        if template_type != 2:
            if parent_child_index > -1 and color_size_flag:
                ws.write(index, parent_child_index, u'父商品')
                
        #if template_type != 2:
        #    if relation_type_index > -1:
        #        ws.write(index, relation_type_index, u'变体')
        
        keyword_dot = keyword_first_index
        if keyword_dot > -1:
            tmp_count = 1
            for keyword in excel_necessity_item.keyword_list:            
                ws.write(index, keyword_dot, keyword)
                
                if template_type == 4 and tmp_count > 0:
                    break
                keyword_dot = keyword_dot + 1
                tmp_count = tmp_count + 1
                if tmp_count > 5:
                    break
        
        url_first_dot = url_first_index
        if url_first_dot > -1:
            tmp_count = 1
            for url in excel_necessity_item.url_list:
                ws.write(index, url_first_dot, url)
                
                if template_type == 4 and tmp_count > 2:
                    break
                url_first_dot = url_first_dot + 1
                tmp_count = tmp_count + 1
                if tmp_count > 9:
                    break
        
        if color_size_flag == False:
            if price_index > -1:
                ws.write(index, price_index, excel_necessity_item.price)
            if reprice_index > -1:
                ws.write(index, reprice_index, excel_necessity_item.reprice) 
            ws.write(index, start_time_index, u'2010-01-01')
            ws.write(index, end_time_index, u'2020-01-01')
            ws.write(index, money_index, u'人民币')
            ws.write(index, store_index, u'1000')
            
        index = index + 1
        
        child_index = 1
        #print 'node',parent_index
        if color_size_flag:
            for color in excel_necessity_item.color_list:
                for size in excel_necessity_item.size_list:
                    #print color,size
                    if title_index > -1:
                        ws.write(index, title_index, excel_necessity_item.title)
                    if desc1_index > -1:
                        ws.write(index, desc1_index, excel_necessity_item.desc1)    
                    if price_index > -1:
                        ws.write(index, price_index, excel_necessity_item.price)
                    if reprice_index > -1:
                        ws.write(index, reprice_index, excel_necessity_item.reprice)                
                    if template_type != 2:
                        if parent_SKU_index > -1 and color_size_flag:
                            ws.write(index, parent_SKU_index, sku_str)
                    if SKU_index > -1:
                        ws.write(index, SKU_index, sku_str + str(child_index))
                    
                    if template_type != 2:
                        if parent_child_index > -1 and color_size_flag:
                            ws.write(index, parent_child_index, u'子商品')
                    if template_type != 2:
                        if relation_type_index > -1 and color_size_flag:
                            ws.write(index, relation_type_index, u'变体')
                    
                    if color_index > -1:
                        if len(color) > 0:
                            ws.write(index,color_index,color)
                    
                    if size_index > -1:
                        if len(size) > 0:
                            ws.write(index,size_index,size)
                            
                    if template_type != 2:
                        if var_index > -1:
                            if len(color) > 0:
                                if  len(size) > 0:
                                    #ws.write(index, var_index, color + '-' + size)
                                    ws.write(index, var_index, u'尺寸颜色')
                                else:
                                    ws.write(index, var_index, u'颜色')
                            elif len(size) > 0:
                                ws.write(index, var_index, u'尺寸')
                            else:
                                ws.write(index, var_index, '')
                        
                    keyword_dot = keyword_first_index
                    if keyword_dot > -1:
                        tmp_count = 1
                        for keyword in excel_necessity_item.keyword_list:
                            ws.write(index, keyword_dot, keyword)
                            if template_type == 4 and tmp_count > 0:
                                break
                            keyword_dot = keyword_dot + 1
                            tmp_count = tmp_count + 1
                            if tmp_count > 5:
                                break
                    
                    url_first_dot = url_first_index
                    if url_first_dot > -1:
                        tmp_count = 1
                        for url in excel_necessity_item.url_list:
                            ws.write(index, url_first_dot, url)
                            if template_type == 4 and tmp_count > 2:
                                break
                            url_first_dot = url_first_dot + 1
                            tmp_count = tmp_count + 1
                            if tmp_count > 9:
                                break

                    ws.write(index, start_time_index, u'2010-01-01')
                    ws.write(index, end_time_index, u'2020-01-01')
                    ws.write(index, money_index, u'人民币')
                    ws.write(index, store_index, u'1000')
                    if color_exist:
                        ws.write(index, colorer_index, u'彩色')
                    
                    index = index + 1
                    child_index = child_index + 1
        parent_index = parent_index + 1
        
    #wb.save(output_filename)
    wb.save('result_' + output_filename)
    print 'Finish'
    
if __name__ == '__main__':
    #excel_name = u'result.xls'
    #excel_name = u'服装鞋帽类.cn.xls'
    #excel_name = u'电子s.cn.xls'
    #template_type = 1
    
    tmp = sys.argv[1]
    tmp_list = tmp.split(';')
    #print tmp_list
    excel_name = tmp_list[0]
    template_type = int(tmp_list[1])
    transfer_txt_to_excel(excel_name,template_type)