﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SocialMed.API.Reports.Domain.Models;
using SocialMed.API.Reports.Domain.Services;
using SocialMed.API.Reports.Resources;
using SocialMed.API.Shared.Extensions;
using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.Reports.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class ReportsController : ControllerBase
{
    private readonly IReportService _reportService;
    private readonly IMapper _mapper;

    public ReportsController(IReportService reportService, IMapper mapper)
    {
        _mapper = mapper;
        _reportService = reportService;
    }
    [HttpGet]
    public async Task<IEnumerable<ReportResource>> GetAllAsync()
    {
        var reports = await _reportService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Report>, IEnumerable<ReportResource>>(reports);

        return resources;

    }
    
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveReportResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var report = _mapper.Map<SaveReportResource, Report>(resource);

        var result = await _reportService.SaveAsync(report);

        if (!result.Success)
            return BadRequest(result.Message);

        var reportResource = _mapper.Map<Report, ReportResource>(result.Resource);

        return Ok(reportResource);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveReportResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var report= _mapper.Map<SaveReportResource, Report>(resource);

        var result = await _reportService.UpdateAsync(id, report);

        if (!result.Success)
            return BadRequest(result.Message);

        var reportResource = _mapper.Map<Report, ReportResource>(result.Resource);

        return Ok(reportResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _reportService.DeleteAsync(id);
        
        if (!result.Success)
            return BadRequest(result.Message);

        var reportResource = _mapper.Map<Report, ReportResource>(result.Resource);

        return Ok(reportResource);
    }
}