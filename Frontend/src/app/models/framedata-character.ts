import { Move } from './move';
import { CharacterStatistics } from './character-statistics';

export interface FrameDataCharacter {
  id: number;
  name: string;
  normalizedName: string;
  moves: Move[];
  fightCoreId: number;
  characterStatistics: CharacterStatistics;
}
