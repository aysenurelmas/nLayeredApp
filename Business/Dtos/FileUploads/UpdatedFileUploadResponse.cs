﻿namespace Business.Dtos.FileUploads;

public class UpdatedFileUploadResponse
{
    public Guid Id { get; set; }
    public string FileName { get; set; }
    public string Destination { get; set; }
    public string Description { get; set; }
}
