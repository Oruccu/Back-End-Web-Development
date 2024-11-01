--1. test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.

-- CREATE TABLE employee (
--     id SERIAL PRIMARY KEY,
--     name VARCHAR(50) NOT NULL,
--     birthday DATE,
--     email VARCHAR(100)
-- );

--2. Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.

-- insert into employee (name, birthday, email) values ('Tomaso Munt', '2018-08-07', 'tmunt0@webmd.com');
-- insert into employee (name, birthday, email) values ('Corine Sacchetti', '2023-01-16', 'csacchetti1@unesco.org');
-- insert into employee (name, birthday, email) values ('Consalve Martindale', '2008-01-06', 'cmartindale2@hc360.com');
-- insert into employee (name, birthday, email) values ('Jessi Jencken', '2004-05-12', 'jjencken3@nbcnews.com');
-- insert into employee (name, birthday, email) values ('Luke Eyree', '2021-11-09', 'leyree4@oaic.gov.au');
-- insert into employee (name, birthday, email) values ('Rodrick Gomersal', '2022-08-01', 'rgomersal5@devhub.com');
-- insert into employee (name, birthday, email) values ('Butch Bernardeschi', '2015-03-11', 'bbernardeschi6@moonfruit.com');
-- insert into employee (name, birthday, email) values ('Wynn Garey', '2021-01-03', 'wgarey7@sakura.ne.jp');
-- insert into employee (name, birthday, email) values ('Gabbey Woodger', '2012-09-17', 'gwoodger8@baidu.com');
-- insert into employee (name, birthday, email) values ('Adolf Christaeas', '2010-10-19', 'achristaeas9@springer.com');
-- insert into employee (name, birthday, email) values ('Arlin Brake', '2012-03-06', 'abrakea@barnesandnoble.com');
-- insert into employee (name, birthday, email) values ('Berkeley Mowatt', '2018-10-21', 'bmowattb@tinyurl.com');
-- insert into employee (name, birthday, email) values ('Esma Grady', '2022-03-21', 'egradyc@networksolutions.com');
-- insert into employee (name, birthday, email) values ('Lennard Matej', '2007-03-28', 'lmatejd@1688.com');
-- insert into employee (name, birthday, email) values ('Fielding Wogdon', '2020-04-30', 'fwogdone@bloglovin.com');
-- insert into employee (name, birthday, email) values ('Archibaldo Warret', '2021-03-07', 'awarretf@dagondesign.com');
-- insert into employee (name, birthday, email) values ('Vilhelmina Burnup', '2011-05-13', 'vburnupg@blogspot.com');
-- insert into employee (name, birthday, email) values ('Anya Tortice', '2004-05-31', 'atorticeh@over-blog.com');
-- insert into employee (name, birthday, email) values ('Rodrigo Canon', '2017-05-31', 'rcanoni@soup.io');
-- insert into employee (name, birthday, email) values ('Gracie Chattell', '2009-10-20', 'gchattellj@rediff.com');
-- insert into employee (name, birthday, email) values ('Tessy Spender', '2004-04-10', 'tspenderk@pen.io');
-- insert into employee (name, birthday, email) values ('Sara Meffen', '2004-01-05', 'smeffenl@dedecms.com');
-- insert into employee (name, birthday, email) values ('Kimble Elleton', '2024-01-13', 'kelletonm@skype.com');
-- insert into employee (name, birthday, email) values ('Anallise Mayston', '2023-01-12', 'amaystonn@issuu.com');
-- insert into employee (name, birthday, email) values ('Franzen Bloor', '2013-02-10', 'fblooro@quantcast.com');
-- insert into employee (name, birthday, email) values ('Shep Heathorn', '2012-01-19', 'sheathornp@cnn.com');
-- insert into employee (name, birthday, email) values ('Meta Romney', '2003-10-15', 'mromneyq@economist.com');
-- insert into employee (name, birthday, email) values ('Ford Loxdale', '2000-12-23', 'floxdaler@aol.com');
-- insert into employee (name, birthday, email) values ('Pete Walas', '2014-12-28', 'pwalass@exblog.jp');
-- insert into employee (name, birthday, email) values ('Bethanne Caraher', '2004-11-17', 'bcarahert@si.edu');
-- insert into employee (name, birthday, email) values ('Kahaleel Lomansey', '2009-06-09', 'klomanseyu@abc.net.au');
-- insert into employee (name, birthday, email) values ('Cherise Klosges', '2009-03-21', 'cklosgesv@cam.ac.uk');
-- insert into employee (name, birthday, email) values ('Gussie Peacocke', '2004-01-01', 'gpeacockew@oracle.com');
-- insert into employee (name, birthday, email) values ('Celka Astall', '2021-05-03', 'castallx@zimbio.com');
-- insert into employee (name, birthday, email) values ('Lavena Soan', '2015-08-28', 'lsoany@who.int');
-- insert into employee (name, birthday, email) values ('Zita Durrance', '2014-12-25', 'zdurrancez@dyndns.org');
-- insert into employee (name, birthday, email) values ('Inga Binley', '2014-05-19', 'ibinley10@blinklist.com');
-- insert into employee (name, birthday, email) values ('Bruno Boddie', '2020-01-18', 'bboddie11@naver.com');
-- insert into employee (name, birthday, email) values ('Joelle Patria', '2008-09-01', 'jpatria12@nasa.gov');
-- insert into employee (name, birthday, email) values ('Yovonnda Tippetts', '2004-03-26', 'ytippetts13@miitbeian.gov.cn');
-- insert into employee (name, birthday, email) values ('Pip Stegers', '1999-06-29', 'pstegers14@ucoz.ru');
-- insert into employee (name, birthday, email) values ('Farlee Went', '2020-01-06', 'fwent15@businesswire.com');
-- insert into employee (name, birthday, email) values ('Clarisse Bastone', '2012-03-14', 'cbastone16@creativecommons.org');
-- insert into employee (name, birthday, email) values ('Bobine Perelli', '2006-09-18', 'bperelli17@mtv.com');
-- insert into employee (name, birthday, email) values ('Jeannette Swiggs', '2016-02-14', 'jswiggs18@cocolog-nifty.com');
-- insert into employee (name, birthday, email) values ('Grayce Giraudel', '2007-12-03', 'ggiraudel19@newsvine.com');
-- insert into employee (name, birthday, email) values ('Ashlie Dwyer', '2012-01-27', 'adwyer1a@artisteer.com');
-- insert into employee (name, birthday, email) values ('Obie Ledward', '2020-07-21', 'oledward1b@twitpic.com');
-- insert into employee (name, birthday, email) values ('Aloise Faudrie', '2011-07-28', 'afaudrie1c@netvibes.com');
-- insert into employee (name, birthday, email) values ('Lesley Durrell', '2021-04-19', 'ldurrell1d@globo.com');

--3. Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.

-- UPDATE employee SET name = 'Ayse', birthday= '1999-10-10', email='test@gmail.com'
-- WHERE id=1
-- RETURNING *;

-- UPDATE employee SET name = 'a ile baslayanlar değişsin'
-- WHERE name ILIKE 'a%'
-- RETURNING *;

-- UPDATE employee SET birthday = '2015-10-19'
-- WHERE birthday= '2010-10-19'
-- RETURNING *;

-- UPDATE employee SET name = 'test'
--  WHERE LENGTH(name)>10 
--  RETURNING *; 

-- UPDATE employee 
-- SET name = 'Tarih Aralığında Güncellendi' 
-- WHERE birthday BETWEEN '1999-01-01' AND '1999-12-31' 
-- RETURNING *;

--4. Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.

-- DELETE FROM employee
-- WHERE id=1
-- RETURNING *; 

-- DELETE FROM employee
-- WHERE birthday BETWEEN '1999-01-01' AND '2000-05-02'
-- RETURNING *;

-- DELETE FROM employee
-- WHERE name ILIKE '%n%n%'
-- RETURNING *;

-- DELETE FROM employee
-- WHERE email = NULL
-- RETURNING *;

-- DELETE FROM employee
-- WHERE name = 'a%' OR birthday = '2000-01-01'
-- RETURNING *;