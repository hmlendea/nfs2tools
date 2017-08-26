﻿using NFS2Tools.DataAccess.DataObjects;

namespace NFS2Tools.DataAccess.IO.Interfaces
{
    public interface IStfManager
    {
        TrackRecordsEntity Read(string path);

        void Write(TrackRecordsEntity statsFileEntity, string path);
    }
}