﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Drizzle.ML.DepthEstimate;

public class ModelInput
{
    public ModelInput(string imagePath, int width, int height)
    {
        ImagePath = imagePath;
        Width = width;
        Height = height;
    }

    public string ImagePath { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
}
