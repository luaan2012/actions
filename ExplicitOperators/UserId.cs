namespace ExplicitOperators
{
	public class UserId
	{
        public UserId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }

        public static implicit operator UserId(Guid guid)
        {
            return new (guid);
        }

		//public static implicit operator Guid(UserId userId)
		//{
		//	return userId.Value;
		//}

		public static explicit operator Guid(UserId userId)
		{
			return userId.Value;
		}
	}

	public class Product
	{
		//public Product(string name, decimal price)
		//{
		//	Name = name;
		//	Price = price;
		//}

		public int Id { get; set; }	
        public decimal Price{ get; set; }
        public string Name { get; set; }
    }

	public class ProductDto
	{
		//public Product(string name, decimal price)
		//{
		//	Name = name;
		//	Price = price;
		//}

		public int Id { get; set; }
		public decimal Price { get; set; }
		public string Name { get; set; }

		public static implicit operator ProductDto(Product product)
		{
			return new()
			{
				Id = product.Id,
				Price = product.Price,
				Name = product.Name
			};
		}

		public static implicit operator Product(ProductDto product)
		{
			return new()
			{
				Id = product.Id,
				Price = product.Price,
				Name = product.Name
			};
		}
	}
}
