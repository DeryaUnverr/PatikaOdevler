

--Soru1: city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.
SELECT C.city,CO.country FROM city C
LEFT JOIN  country CO
ON 
C.country_id=CO.country_id

--Soru2: customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.
SELECT P.payment_id, C.first_name, C.last_name  FROM customer C
RIGHT JOIN payment P
ON 
P.customer_id=C.customer_id

--Soru3: customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz FULL JOIN sorgusunu yazınız.
SELECT  R.rental_id,C.first_name,C.last_name FROM rental R
FULL JOIN  customer C
ON
R.customer_id=C.customer_id

