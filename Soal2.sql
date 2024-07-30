WITH LatestStock AS (
    SELECT 
        KodeBarang, 
        StokAkhir, 
        ROW_NUMBER() OVER(PARTITION BY KodeBarang ORDER BY Tanggal DESC, KodeStok DESC) AS RowNum
    FROM 
        HistoriStokBarang
)
SELECT 
    KodeBarang, 
    StokAkhir
FROM 
    LatestStock
WHERE 
    RowNum = 1;