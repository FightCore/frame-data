using FightCore.FrameData;
using FightCore.Models;

namespace FightCore.GraphQL.Types;

[QueryType]
public class Query
{
    [UseProjection]
    [UseFiltering]
    public IQueryable<Character> GetCharacters(FrameDataContext frameDataContext)
    {
        return frameDataContext.Characters.OrderBy(character => character.Name);
    }

    [UseProjection]
    [UseFiltering]
    public IQueryable<Move> GetMoves(FrameDataContext frameDataContext, string normalizedName)
    {
        return frameDataContext.Characters.Where(character => character.NormalizedName == normalizedName)
            .SelectMany(character => character.Moves);
    }

    [UseProjection]
    [UseFiltering]
    public IQueryable<Hit> GetHits(FrameDataContext frameDataContext, string characterName, string moveName)
    {
        return frameDataContext.Characters.Where(character => character.NormalizedName == characterName)
            .SelectMany(character => character.Moves).Where(move => move.NormalizedName == moveName)
            .SelectMany(move => move.Hits);
    }
}