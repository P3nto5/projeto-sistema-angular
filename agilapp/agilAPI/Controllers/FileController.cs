using System.Security.Claims;
using System.Threading.Tasks;
using agilAPI.Data;
using agilAPI.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace agilAPI.Controllers
{
    [Authorize]
    [Route("api/users/{userId}/files")]
    [ApiController]


    public class FileController : ControllerBase
    {
        private readonly IDatingRepository _repo;
        private readonly IMapper _mapper;
        public FileController(IDatingRepository repo, IMapper mapper)
        {
            this._mapper = mapper;
            this._repo = repo;

        }

        [HttpGet("{id}", Name = "GetFile")]
        public async Task<IActionResult> GetFile(int id){
            var fileFromRepo = await _repo.GetFile(id);
            var file = _mapper.Map<FileForReturnDto>(fileFromRepo);
            return Ok(file);
        }

        [HttpPost]
        public async Task<IActionResult> AddFileForUser(int userId,
        [FromForm]FileForCreationDto fileForCreationDto){
            if(userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();
        var userFromRepo = await _repo.GetUser(userId);
        var file = fileForCreationDto.File;

        if(file.Length> 0){

            using (var stream = file.OpenReadStream()){
                string imageName = System.IO.Path.GetFileName(file.FileName);

            }
        }

        return BadRequest("Could not add the file");
        }

    }
}