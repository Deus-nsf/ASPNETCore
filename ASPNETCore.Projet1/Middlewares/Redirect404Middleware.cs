namespace ASPNETCore.Projet1.Middlewares;

public class Redirect404Middleware
{
	private readonly RequestDelegate _next;
	
	public Redirect404Middleware(RequestDelegate next)
	{
		_next = next;
	}

	public async Task InvokeAsync(HttpContext context)
	{
		await _next(context);

		if (context.Response.StatusCode == 404)
		{
			//context.Response.Redirect("/Home/NotFoundCustom?urlRequest=" +
			//							context.Request.Host.Value + 
			//							context.Request.Path, false) ;

			context.Response.Redirect("./Home/Error", false) ;
		}
	}
}
