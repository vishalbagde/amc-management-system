select complain_id,comp_date,solve_date from complain_tbl

select comp_date,count(comp_date) as count_complain, count(comp_date)*100.00 /
(select count(comp_date) from complain_tbl
where
 comp_date >= '01-01-2019'
and comp_date <= '03-22-2019'
) as per
 from complain_tbl
where solve_date > comp_date
and comp_date >= '01-01-2019'
and comp_date <= '03-22-2019'
group by comp_date