import { ElementType } from './element-type';
import { HurtboxInteractionFlags } from './hurtbox-interaction-flags';
import { ScriptCommand } from './script-command';

export interface HitboxCommand extends ScriptCommand {
  hitboxId: number;
  unknownR: number;
  boneId: number;
  unknown0: number;
  unknownQ: number;
  unknownV: number;
  size: number;
  zOffset: number;
  yOffset: number;
  xOffset: number;
  hurtboxInteractionFlags: HurtboxInteractionFlags;
  baseKnockback: number;
  shieldDamage: number;
  sfx: number;
  hitsGround: boolean;
  hitsAir: boolean;
  knockbackGrowth: number;
  damage: number;
  weightDependantKnockback: number;
  element: ElementType;
  angle: number;
}
