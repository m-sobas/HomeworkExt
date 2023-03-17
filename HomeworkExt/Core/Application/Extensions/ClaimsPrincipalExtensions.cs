using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security.Claims;

namespace HomeworkExt.Core.Application.Extensions
{
	public static class ClaimsPrincipalExtensions
	{
		public static string GetUserId(this ClaimsPrincipal model)
		{
			return model.FindFirstValue(ClaimTypes.NameIdentifier);
		}
	}
}
