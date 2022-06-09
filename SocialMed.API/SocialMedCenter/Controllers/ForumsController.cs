using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SocialMed.API.Forums.Resources;
using SocialMed.API.Shared.Extensions;
using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Domain.Services;
using SocialMed.API.SocialMedCenter.Resources;

namespace SocialMed.API.SocialMedCenter.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class ForumsController  : ControllerBase
{
    private readonly IForumService _forumService;
    private readonly IMapper _mapper;

    public ForumsController(IForumService forumService, IMapper mapper)
    {
        _mapper = mapper;
        _forumService = forumService;
    }
    [HttpGet]
    public async Task<IEnumerable<ForumResource>> GetAllAsync()
    {
        var forums = await _forumService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Forum>, IEnumerable<ForumResource>>(forums);

        return resources;

    }
    
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveForumResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var forum = _mapper.Map<SaveForumResource, Forum>(resource);

        var result = await _forumService.SaveAsync(forum);

        if (!result.Success)
            return BadRequest(result.Message);

        var forumResource = _mapper.Map<Forum, ForumResource>(result.Resource);

        return Ok(forumResource);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveForumResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var forum= _mapper.Map<SaveForumResource, Forum>(resource);

        var result = await _forumService.UpdateAsync(id, forum);

        if (!result.Success)
            return BadRequest(result.Message);

        var forumResource = _mapper.Map<Forum, ForumResource>(result.Resource);

        return Ok(forumResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _forumService.DeleteAsync(id);
        
        if (!result.Success)
            return BadRequest(result.Message);

        var forumResource = _mapper.Map<Forum, ForumResource>(result.Resource);

        return Ok(forumResource);
    }
}