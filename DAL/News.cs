﻿namespace DAL
{
    public class News
    {
        Guid NewsId { get; set; }
        public string NewsTitle { get; set; }
        public string? NewsText { get; set; }
        public string? PhotoName { get; set; }
        public string? NewsLink { get; set; }
    }
}