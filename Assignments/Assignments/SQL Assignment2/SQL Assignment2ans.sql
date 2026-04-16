
SELECT first_name,last_name,order_id,order_date,order_status
FROM customers C JOIN orders O
ON c.customer_id = o.customer_id
WHERE O.order_status IN (1,4)
ORDER BY order_date DESC


SELECT p.product_name,b.brand_name,c.category_name,b.model_year,p.list_price
FROM products p join brands b
ON p.brand_id = b.brand_id
join categories c
ON c.category_id = p.category_id
where p.list_price >= 500
order by p.list_price asc

