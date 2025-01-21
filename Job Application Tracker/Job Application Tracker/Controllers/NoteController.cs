using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Job_Application_Tracker.Controllers
{
    [RoutePrefix("api/note")]
    public class NoteController : ApiController
    {
        [HttpPost]
        [Route("create/{id}")]
        public HttpResponseMessage Create(NoteDTO obj, int id)
        {
            try
            {
                var data = NoteService.Create(obj, id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = NoteService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(int id)
        {

            try
            {
                var data = NoteService.Get(id);
                if (data != null)
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                else return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Note not Found" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }

        }
        [HttpPost]
        [Route("update")]
        public HttpResponseMessage Update(NoteDTO obj)
        {
            try
            {
                var data = NoteService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = NoteService.Delete(id);
                if (data)
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                else return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Note Unable To Delete" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
