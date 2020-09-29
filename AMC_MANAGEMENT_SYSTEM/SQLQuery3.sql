select  
cast (ser.service_date as date),
cust.customer_name,cust.area_name,
ser.service_status,
ser.service_id

from service_tbl ser,contract_tbl con,customer_tbl cust
where
ser.contract_id=con.contract_id 
and con.cust_id=cust.customer_id
and (service_status = 'pending' or service_Status = 'allocated')
order by service_date