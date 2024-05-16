import { ScriptCommand } from './script-command';
import { VisibilityConstant } from './visibility-constant';

export interface VisibilityCommand extends ScriptCommand {
  visibility: VisibilityConstant;
}
