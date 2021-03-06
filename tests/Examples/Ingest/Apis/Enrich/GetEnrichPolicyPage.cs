using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Ingest.Apis.Enrich
{
	public class GetEnrichPolicyPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line37()
		{
			// tag::af18f5c5fb2364ae23c6a14431820aba[]
			var response0 = new SearchResponse<object>();
			// end::af18f5c5fb2364ae23c6a14431820aba[]

			response0.MatchesExample(@"GET /_enrich/policy/my-policy");
		}

		[U(Skip = "Example not implemented")]
		public void Line116()
		{
			// tag::8684589e31d96ab229e8c4feb4d704bb[]
			var response0 = new SearchResponse<object>();
			// end::8684589e31d96ab229e8c4feb4d704bb[]

			response0.MatchesExample(@"GET /_enrich/policy/my-policy,other-policy");
		}

		[U(Skip = "Example not implemented")]
		public void Line168()
		{
			// tag::c97fd95ebdcf56cc973582e37f732ed2[]
			var response0 = new SearchResponse<object>();
			// end::c97fd95ebdcf56cc973582e37f732ed2[]

			response0.MatchesExample(@"GET /_enrich/policy");
		}
	}
}