using MI9.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace MI9.Controllers
{
    public class PayloadController : ApiController
    {
        /// <summary>
        /// Return list of payload with drm and episodecount > 0
        /// </summary>
        /// <param name="request">Json object provided in the sample</param>
        /// <returns>Json response provided by test</returns>
        [AcceptVerbs("GET","POST","OPTIONS")]
        public Response Get(Request request)
        {
            try
            {
                var shows = request.Payload
                    .Where(x => x.DRM.HasValue && x.DRM.Value && x.EpisodeCount.HasValue && x.EpisodeCount.Value > 0)
                    .Select(x => new ShowResponse
                    {
                        Image = x.Image == null ? null : x.Image.ShowImage,
                        Slug = x.Slug,
                        Title = x.Title
                    })
                    .ToList();
                var response = new Response();
                response.response = shows;
                return response;
            }
            catch (Exception)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest);
                resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                resp.Content = new StringContent(new JObject(new JProperty ("error","Could not decode request: JSON parsing failed")).ToString());
                resp.ReasonPhrase = "Bad Request";
                throw new HttpResponseException(resp);
            }

        }

    }
}
