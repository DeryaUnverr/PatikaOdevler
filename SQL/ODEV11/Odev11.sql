

--Soru1: actor ve customer tablolarında bulunan first_name sütunları için tüm verileri sıralayalım.
 (Select first_name from actor)
 UNION 
 (select first_name from customer);
 
--Soru2: actor ve customer tablolarında bulunan first_name sütunları için kesişen verileri sıralayalım.
 (Select first_name from actor)
 INTERSECT
 (select first_name from customer);
 
--Soru3: actor ve customer tablolarında bulunan first_name sütunları için ilk tabloda bulunan ancak ikinci tabloda bulunmayan verileri sıralayalım.
 (Select first_name from actor)
  EXCEPT
 (select first_name from customer);
--Soru4: İlk 3 sorguyu tekrar eden veriler için de yapalım.

 (Select first_name from actor)
 UNION ALL
 (select first_name from customer);
 -----------------------------------------------------------------------
 (Select first_name from actor)
 INTERSECT ALL
 (select first_name from customer);
 -----------------------------------------------------------------------
 (Select first_name from actor)
  EXCEPT ALL
 (select first_name from customer);

