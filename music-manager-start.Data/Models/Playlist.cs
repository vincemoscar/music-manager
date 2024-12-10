﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using music_manager_starter.Data.Models;

namespace music_manager_starter.Data.Models
{
    public sealed class Playlist
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
    }
}