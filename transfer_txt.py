# -*- coding: UTF-8 -*-

import xlwt,xlrd
import codecs
from datetime import datetime
import MySQLdb
import math
import os

class necessity_info:
    # need info
    # title,desc,color_list,size_list,url_list,key_word_list,price
    def __init__(self,title,desc,price,keyword_list,item_id,shop,color_list,size_list,url_list,url_list_str):
        self.title = title
        self.desc = desc
        self.price = price
        self.keyword_list = keyword_list
        self.item_id = item_id
        self.shop = shop
        self.color_list = color_list
        self.size_list = size_list
        self.url_list = url_list
        self.url_list_str = url_list_str
    
    def __str__(self):
        return self.title
        
def transfer_txt_to_excel(input_filename):
    print input_filename
    
    # price dict
    price_dict = {}
    reprice_dict = {}
    b_price = True

    f_price = open('price.txt')
    ct = 1
    for line in f_price:
        #print line
        if u'price' in line:
            b_price = True
            continue
        if u'reprice' in line:
            b_price = False
            continue
        line_list = line.split(u';')
        
        if ct > 9:            
            b_price = False
            
        if len(line_list) > 1:
            if b_price == True:
                price_dict[line_list[0]] = float(line_list[1])
                #print 'price',line_list[0],int(line_list[1])
            else:
                reprice_dict[line_list[0]] = float(line_list[1])
                #print 'reprice',line_list[0],int(line_list[1])
        ct = ct + 1
        
    #print reprice_dict
    '''
    for key in price_dict.keys:
        print key
    for value in price_dict.values:
        print value
    '''    
    # read txt
    f = codecs.open(input_filename, encoding='utf-8')
    count = 1
    necessity_info_list = []
    color_list = []
    size_list = []
    url_list = []
    keyword_list = []
    url_list_str = ""
    item_id = -1
    shop = ""
    for line in f.readlines():
        line = line.strip()
		
        #print count
		
        # deal with desc with special function
        desc_start = line.find(u'商品编号')
        desc_end = line.find(u'价格')
        #print desc_start,desc_end
        if desc_end > desc_start:
            desc = line[desc_start : desc_end]
        else:
            desc = ""
        #print 'desc',desc
        
        desc_list = desc.split(',')
        result_desc = ""
        for ele in desc_list:
            if u'店铺：' in ele:
                continue
            if u'品牌：' in ele    :
                continue
            result_desc = result_desc + ele + ","
        #print 'result_desc ',result_desc
        desc = result_desc
        
        keywords_start = line.find('KeyWords:{')
        keywords_end = line.find('}',keywords_start)
        #print keywords_start, keywords_end
        if keywords_end > keywords_start:
            keywords_sub = line[keywords_start+10 : keywords_end]
        else:
            keywords_sub = ""
        #print 'keyword_list',keywords_sub
        keywords_str_list = keywords_sub.split(',')
        for element in keywords_str_list:
            keyword_list.append(element)
        
        # deal with element
        str_list = line.split(',')        
        for element in str_list:
            #print element
            
            if u'title' in element:
                sub_element_list = element.split(':')                
                title = sub_element_list[1].strip()
                #print 'title ', title
            elif u'商品编号' in element:
                sub_element_list = element.split(u'：')
                item_id = sub_element_list[1].strip()
                #print 'item_id ', item_id
            elif u'价格：' in element:
                sub_element_list = element.split(u'：')
                price = sub_element_list[1].strip()
                price = price[1:]
                if price != "":                    
                    price = float(price)
                    #print 'original price', price
                    if 0 < price <= 100:
                        price = price + price_dict[u'0-100']    
                    elif price <= 200:
                        price = price + price_dict[u'100-200']
                    elif price <= 500:
                        price = price + price_dict[u'200-500']
                    elif price <= 1000:
                        price = price + price_dict[u'500-1000']
                    elif price <= 2000:
                        price = price + price_dict[u'1000-2000']
                    elif price <= 3000:
                        price = price + price_dict[u'2000-3000']
                    elif price <= 5000:
                        price = price + price_dict[u'3000-5000']
                    elif price <= 10000:
                        price = price + price_dict[u'5000-10000']
                    else:
                        price = price + price_dict[u'>10000']
                else:
                    price = 0
                price = str(price)
                #print 'changed_price ', price
                
            elif u'店铺' in element:
                sub_element_list = element.split(u'：')               
                shop = ""
                #print 'shop ', shop
            elif u'[选择颜色' in element:
                element_list = element.split(u'：')
                sub_element_list = element_list[1].split(u';')
                for sub_element in sub_element_list:
                    sub_element = sub_element.strip()
                    if sub_element.endswith(u']'):
                        sub_element = sub_element[:-1]
                    if sub_element.startswith(u':'):
                        sub_element = sub_element[1:]
                    #print sub_element
                    
                    color_list.append(sub_element)
            elif u'[选择尺码' in element:
                element_list = element.split(u'：')                
                sub_element_list = element_list[1].split(u';')
                for sub_element in sub_element_list:
                    sub_element = sub_element.strip()
                    if sub_element.endswith(u']'):
                        sub_element = sub_element[:-1]
                    if sub_element.startswith(u':'):
                        sub_element = sub_element[1:]
                    #print sub_element
                    
                    size_list.append(sub_element)    
            elif u'{imglist' in element:                
                element_list = element.split(u':')                
                sub_element_list = element_list[1].split(u';')
                for sub_element in sub_element_list:
                    sub_element = sub_element.strip()
                    if sub_element.endswith(u'}'):
                        sub_element = sub_element[:-1]
                    if len(sub_element) > 0:
                        url_list_str = sub_element + ";" + url_list_str 
                        url_list.append(sub_element)
                #print str(url_list)            
        necessity_info_list.append(necessity_info(title,desc,price,keyword_list,item_id,shop,color_list,size_list,url_list,url_list_str))
        color_list = []
        size_list = []
        url_list = []
        keyword_list = []
        url_list_str = ""
        shop = ""
        item_id = -1
        #if count > 1:
        #    break
        count = count + 1
    
    '''
    print '\n'
    print 'read file result'
    for element in necessity_info_list:
        print '\nITEM'
        print element.shop
        for item in element.color_list:
            print item + ','
        for item in element.size_list:
            print item + ','
    '''
    
    # insert into database    
    try:
        conn=MySQLdb.connect(host='localhost',user='root',passwd='123456',port=3306)
        conn.set_character_set('utf8')
        cur=conn.cursor()
        
        # create db if not exists
        cur.execute('create database if not exists smth_linpingta;')
        conn.commit()
        
        conn.select_db('smth_linpingta')
        
        cur.execute('SET NAMES utf8;')
        cur.execute('SET CHARACTER SET utf8;')
        cur.execute('SET character_set_connection=utf8;')
        # delete already exist info
        cur.execute('drop table if exists smth_linpingta.smth2')
        # create table if not exists
        cur.execute("CREATE TABLE IF NOT EXISTS `smth_linpingta`.`smth2` ( `ID` INT NOT NULL AUTO_INCREMENT,`TITLE` VARCHAR(512) NULL,`DESC1` VARCHAR(512) NULL,`PRICE` DECIMAL(10,2) NULL,`KEYWORDS` VARCHAR(512) NULL,`COLORLIST` VARCHAR(2048) NULL,`SIZELIST` VARCHAR(2048) NULL,`URLLIST` VARCHAR(2048) NULL,`REPRICE` DECIMAL(10,2) NULL,PRIMARY KEY (`ID`))ENGINE = InnoDB;")
        conn.commit()
                
        index = 1
        for e_info in necessity_info_list:
            print index
            keywords_comma_list = ""
            url_comma_list = ""
            color_comma_list = ""
            size_comma_list = ""
            count = 1
            for element in e_info.keyword_list:
                keywords_comma_list = keywords_comma_list + element
                if count < len(e_info.keyword_list):
                    keywords_comma_list = keywords_comma_list + ","
                count = count + 1
            
            count = 1
            for element in e_info.url_list:
                url_comma_list = url_comma_list + element
                if count < len(e_info.url_list):
                    url_comma_list = url_comma_list + ","
                count = count + 1
            
            count = 1
            for element in e_info.color_list:
                color_comma_list = color_comma_list + element
                if count < len(e_info.color_list):
                    color_comma_list = color_comma_list + ","
                count = count + 1
                
            count = 1
            for element in e_info.size_list:
                size_comma_list = size_comma_list + element
                if count < len(e_info.size_list):
                    size_comma_list = size_comma_list + ","
                count = count + 1
            
            price = float(e_info.price)
            reprice = price
            #print price
            if price == 0:
                reprice = 0
            elif 0 < price <= 100:
                reprice = price + reprice_dict[u'0-100']
            elif price <= 200:
                reprice = price + reprice_dict[u'100-200']
            elif price <= 500:
                reprice = price + reprice_dict[u'200-500']
            elif price <= 1000:
                reprice = price + reprice_dict[u'500-1000']
            elif price <= 2000:
                reprice = price + reprice_dict[u'1000-2000']
            elif price <= 3000:
                reprice = price + reprice_dict[u'2000-3000']
            elif price <= 5000:
                reprice = price + reprice_dict[u'3000-5000']
            elif price <= 10000:
                reprice = price + reprice_dict[u'5000-10000']
            else:
                reprice = price + reprice_dict[u'>10000']
            #print reprice
            reprice = str(reprice)
            
            cur.execute("insert into smth_linpingta.smth2 (TITLE, DESC1, PRICE, KEYWORDS, COLORLIST, SIZELIST, URLLIST, REPRICE) values('" + e_info.title + \
                        "','" + e_info.desc + "'," + e_info.price + \
                        ",'" + keywords_comma_list + "','" + color_comma_list + \
                        "','" + size_comma_list + "','" + url_comma_list + "'," + reprice + \
                        ");")
            conn.commit()
            #print index
            index = index + 1
        cur.close()
        conn.close()
        
        print 'finish'
    except MySQLdb.Error,e:
        print "Install Mysql First"
        print e
    
if __name__ == '__main__':
    txt_name = 'output.txt'
    transfer_txt_to_excel(txt_name)