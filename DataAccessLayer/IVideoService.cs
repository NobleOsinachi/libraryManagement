﻿using System.Collections.Generic;
using DataAccessLayer.Models;

namespace lms.DataAccessLayer
{
    public interface IVideoService
    {
        IEnumerable<Video> GetAll();
        IEnumerable<Video> GetByDirector(string author);
        Video Get(int id);
        void Add(Video newVideo);
    }
}