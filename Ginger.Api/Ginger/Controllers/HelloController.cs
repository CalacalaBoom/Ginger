using $ext_safeprojectname$.Core.Models;
using $ext_safeprojectname$.Core;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using $ext_safeprojectname$.Comon;

namespace $ext_safeprojectname$.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HelloController : ControllerBase
    {
        private ISqlSugarClient _db;
        private Repository<Testtb> _repository;
        //依赖注入
        public HelloController(ISqlSugarClient db, Repository<Testtb> repository)
        {
            _db = db;
            _repository = repository;
        }

        /// <summary>
        /// 测试接口
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        public RESTFulDto<List<Testtb>> LetsDance()
        {
            var list = _repository.GetList();
            return new RESTFulDto<List<Testtb>>(list);
        }

        [HttpPost]
        public RESTFulDto<string> PostMan([FromBody]string man)
        {
            return new RESTFulDto<string>(man);
        }
    }
}
