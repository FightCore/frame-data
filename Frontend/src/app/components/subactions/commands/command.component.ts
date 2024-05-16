import { Component, Input, OnInit } from '@angular/core';
import { ScriptCommand } from 'src/app/models/commands/script-command';

@Component({ template: '' })
export class CommandComponent<TScriptCommand extends ScriptCommand> implements OnInit {
  specificCommand?: TScriptCommand;
  @Input() command?: ScriptCommand;

  ngOnInit(): void {
    this.specificCommand = this.command as TScriptCommand;
  }
}
