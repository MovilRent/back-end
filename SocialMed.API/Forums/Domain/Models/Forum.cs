﻿using SocialMed.API.Security.Domain.Models;

namespace SocialMed.API.Forums.Domain.Models;

public class Forum
{ 
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    
    public DateTime Date { get; set; }

    //relationsship
    public int UserId { get; set; }
    public User User { get; set; }
    public int RatingId { get; set; }

    public IList<Comment> Comments { get; set; } = new List<Comment>();
    public IList<Rating> Ratings { get; set; } = new List<Rating>();

    
}