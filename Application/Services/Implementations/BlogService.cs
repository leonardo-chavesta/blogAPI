﻿using Application.Dtos.Blogs;
using Application.Dtos.Perfiles;
using Application.Services.Abstractions;
using AutoMapper;
using Domain;
using Infraestructure.Repositories.Abstractions;
using Infraestructure.Repositories.Implementacions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    public class BlogService : IBlogService
    {
        private readonly IMapper _mapper;
        private readonly IBlogRepository _blogRepository;
        public BlogService(IMapper mapper, IBlogRepository blogRepository)
        {
            _mapper = mapper;   
            _blogRepository = blogRepository;   
        }

        public async Task<BlogDto?> Buscar(int id)
        {
            var response = await _blogRepository.Buscar(id);

            return _mapper.Map<BlogDto?>(response);
        }

        public async Task<BlogDto?> EditBlog(int id, BlogFormDto entity)
        {
            
            var dto = _mapper.Map<Blog>(entity);

            var response = await _blogRepository.EditBlog(id,dto);

            return _mapper.Map<BlogDto>(response);
        }

        public async Task<IList<BlogDto>> ListaBlogs()
        {
            var response = await _blogRepository.ListaBlogs();

            return _mapper.Map<IList<BlogDto>>(response);
        }
    }
}