import { CommandType } from './command-type';

export interface ScriptCommand {
  id: number;
  displayName: string;
  name: string;
  type: number;
  length: number;
  hexString: string;
  commandType: CommandType;
  order: number;
}
