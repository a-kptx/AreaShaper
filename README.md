# AreaShaper

Ответ на второй вопрос:

SELECT productName, categoryName
FROM Products p
LEFT JOIN ProductsInCategories pic ON p.Id = pic.productId
LEFT JOIN Categories c ON pic.categoryId = c.Id