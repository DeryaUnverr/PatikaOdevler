

--Soru1: city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
SELECT C.city,CO.country FROM city C
INNER JOIN  country CO
ON 
C.country_id=CO.country_id

--Soru2: customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
SELECT P.payment_id, C.first_name, C.last_name  FROM customer C
INNER JOIN payment P
ON 
P.customer_id=C.customer_id

--Soru3: customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
SELECT  R.rental_id,C.first_name,C.last_name FROM rental R
INNER JOIN  customer C
ON
R.customer_id=C.customer_id

