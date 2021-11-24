

--Soru1: film tablosunda bulunan replacement_cost sütununda bulunan birbirinden farklı değerleri sıralayınız
SELECT DISTINCT replacement_cost FROM film;

--Soru2: film tablosunda bulunan replacement_cost sütununda birbirinden farklı kaç tane veri vardır?
SELECT COUNT(DISTINCT replacement_cost ) FROM film;

--Soru3: film tablosunda bulunan film isimlerinde (title) kaç tanesini T karakteri ile başlar ve aynı zamanda rating 'G' ye eşittir?
SELECT cOUNT(*) FROM film Where title LIKE 'T%' AND rating='G';

--Soru4: country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluşmaktadır?
select COUNT(COUNTRY) from country where country LIKE '_____';

--Soru5: city tablosundaki şehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter?
SELECT COUNT(*) FROM CITY WHERE CITY ILIKE '%R';

