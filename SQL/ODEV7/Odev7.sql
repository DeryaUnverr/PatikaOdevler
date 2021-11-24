

--Soru1: film tablosunda bulunan filmleri rating değerlerine göre gruplayınız.
SELECT rating FROM film GROUP BY  rating;

--Soru2: film tablosunda bulunan filmleri replacement_cost sütununa göre grupladığımızda film sayısı 50 den fazla olan replacement_cost değerini ve karşılık gelen film sayısını sıralayınız.
SELECT replacement_cost,count(*) FROM film GROUP BY replacement_cost HAVING count(*)>50;

--Soru3: customer tablosunda bulunan store_id değerlerine karşılık gelen müşteri sayılarını nelerdir?
SELECT store_id,count(*) FROM customer group by store_id ;

--Soru4: city tablosunda bulunan şehir verilerini country_id sütununa göre gruplandırdıktan sonra en fazla şehir sayısı barındıran country_id bilgisini ve şehir sayısını paylaşınız.
SELECT country_id,count(*) FROM city group by country_id  ORDER BY COUNT(*) DESC LIMIT 1

