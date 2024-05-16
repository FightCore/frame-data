import { BodyType } from './body-type';
import { ScriptCommand } from './script-command';

export interface BodyStateCommand extends ScriptCommand {
  bodyType: BodyType;
}
