with q
as
(select m.Sehir,su.Tutar from Musteris m join Sepets s on 
	s.MusteriId = m.Id
	join SepetUruns su on su.SepetId = s.Id
	where m.Sehir ='Ýstanbul') 
	select q.Sehir,COUNT(q.Sehir),SUM(q.Tutar) from q
	group by q.Sehir;

with query
  as
  (select m.Sehir,m.Id as musteriId,su.Tutar from Sepets s
		join Musteris m on m.Id = s.MusteriId
		join SepetUruns su on su.SepetId =s.Id
		group by m.Sehir,m.Id,su.Tutar,s.Id) 
	select 
		Count(musteriId) SepetAdedi
		,Sehir,
		Sum(Tutar) as Tutar 
	from query group by Sehir 
	order by SepetAdedi desc;

	SELECT [t3].[Sehir] AS [SehirAdi], [t3].[value] AS [SepetAdeti], [t3].[value2] AS [ToplamTutar]
FROM (
    SELECT COUNT(*) AS [value], SUM([t0].[Tutar]) AS [value2], [t2].[Sehir]
    FROM [SepetUruns] AS [t0]
    INNER JOIN [Sepets] AS [t1] ON [t0].[SepetId] = [t1].[Id]
    INNER JOIN [Musteris] AS [t2] ON [t1].[MusteriId] = [t2].[Id]
    GROUP BY [t2].[Sehir]
    ) AS [t3]
ORDER BY [t3].[value2] DESC, [t3].[value]

