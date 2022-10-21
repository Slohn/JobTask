select Products.Name,categories.Name from Products 
LEft Join ProductsToCategories on Products.Id = ProductsToCategories.ProductId 
Left Join categories on ProductsToCategories.Categoryid = categories.Id
