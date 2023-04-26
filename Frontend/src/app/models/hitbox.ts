export interface Hitbox {
  name: string;
  damage: number;
  angle: number;
  knockbackGrowth: number;
  setKnockback: number;
  baseKnockback: number;
  effect: string;
  hitlagAttacker: number;
  hitlagDefender: number;
  hitlagAttackerCrouched: number;
  hitlagDefenderCrouched: number;
  shieldstun: number;
  yoshiArmorBreakPercentage: number;
}
