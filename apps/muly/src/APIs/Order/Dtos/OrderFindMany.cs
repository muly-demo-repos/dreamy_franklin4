using Microsoft.AspNetCore.Mvc;
using Muly.Infrastructure.Models;

namespace Muly.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class OrderFindMany : FindManyInput<Order, OrderWhereInput> { }
