﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_manager_starter.Shared
{
    public sealed class Playlist
{
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
}
}
