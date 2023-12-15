import { ScriptCommand } from './script-command';

export interface AutoCancelCommand extends ScriptCommand {
  autoCancelEnabled: boolean;
}
