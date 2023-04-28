import { Move } from './move';
import { CharacterStatistics } from './character-statistics';

export interface Character {
  id: number;
  name: string;
  normalizedName: string;
  moves: Move[];
  fightCoreId: number;
  characterStatistics: CharacterStatistics;
}
