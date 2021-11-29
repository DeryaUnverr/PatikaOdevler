

--Soru1:film tablosunda film uzunluğu length sütununda gösterilmektedir. Uzunluğu ortalama film uzunluğundan fazla kaç tane film vardır?
select count(*) from film
where length> any
(select avg(length) from film);

--Soru2:film tablosunda en yüksek rental_rate değerine sahip kaç tane film vardır?
Select count(*) from film where rental_rate= ANY
(
select max(rental_rate) from film
);

--Soru3:film tablosunda en düşük rental_rate ve en düşük replacement_cost değerlerine sahip filmleri sıralayınız.
Select * from film where rental_rate= ANY
(select min(rental_rate) from film) AND replacement_cost=ANY(select min(replacement_cost) from film);

--Soru4:payment tablosunda en fazla sayıda alışveriş yapan müşterileri(customer) sıralayınız.
SELECT * FROM customer WHERE customer_id = ANY
( SELECT customer_id FROM payment GROUP BY customer_id ORDER BY count(*) DESC )



