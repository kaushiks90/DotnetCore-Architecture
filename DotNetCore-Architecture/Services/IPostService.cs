﻿using DotNetCore_Architecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore_Architecture.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetPostsAsync();

        Task<Post> GetPostByIdAsync(Guid postId);

        Task<bool> CreatePostAsync(Post post);

        Task<bool> UpdatePostAsync(Post post);

        Task<bool> DeletePostAsync(Guid postId);

        Task<bool> UsersOwnsPostAsync(Guid posrId, string userId);
    }
}
