
/* product_cunsume_service_wise_view */
create view product_cunsume_service_wise_view
as
select 
pc.pc_id,pc.service_id,sr_no,pc.product_id,pc.qty,pc.status,pc.entry_date,pro.product_name
from product_consume_tbl pc,product_mstr pro
where pc.product_id=pro.product_id;



/* product_consume_complain_wise_groupby_view */
create view product_consume_complain_wise_groupby_view
as
select comp.complain_id,comp.customer_id,comp.remark,
cust.customer_name,
pc.pc_id,pc.sr_no,pc.product_id,pc.qty,pc.entry_date,
pro.product_name
from complain_tbl comp,customer_tbl cust,product_consume_tbl pc,
product_mstr pro
where comp.customer_id=cust.customer_id
and comp.complain_id=pc.complain_id
and pro.product_id=pc.product_id

