using ExplicitOperators;
using System.Net.Http.Headers;

var guidId = new Guid();
UserId userId =  guidId;
Guid userIdConverted = (Guid)userId;

var teste = 0;

var product = new Product
{
	Name = "Some product",
	Price = 69m
};

ProductDto productDto = product;

int number = 430;

object testae = number;
