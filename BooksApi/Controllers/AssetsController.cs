using BooksApi.Models;
using BooksApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        private readonly AssetService _assetService;

        public AssetsController(AssetService assetService)
        {
            _assetService = assetService;
        }

        [HttpGet]
        public ActionResult<List<Asset>> Get() =>
            _assetService.Get();

        [HttpGet("{id:length(24)}/", Name = "GetAsset")]
        public ActionResult<Asset> Get(string id)
        {
            var asset = _assetService.Get(id);

            if (asset == null)
            {
                return NotFound();
            }

            return asset;
        }

        [HttpPost]
        public ActionResult<Asset> Create(Asset asset)
        {
            _assetService.Create(asset);

            return CreatedAtRoute("GetAsset", new {id = asset.Id.ToString()}, asset);
        }
    }
}
