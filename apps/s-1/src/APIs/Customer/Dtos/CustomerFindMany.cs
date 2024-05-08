using Microsoft.AspNetCore.Mvc;
using S1.Infrastructure.Models;

namespace S1.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CustomerFindMany : FindManyInput<Customer, CustomerWhereInput> { }
