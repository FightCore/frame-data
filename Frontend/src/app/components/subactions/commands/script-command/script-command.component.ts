import { Component, Input, OnInit } from '@angular/core';
import { CommandType } from 'src/app/models/commands/command-type';
import { ScriptCommand } from 'src/app/models/commands/script-command';

@Component({
  selector: 'app-script-command',
  templateUrl: './script-command.component.html',
  styleUrls: ['./script-command.component.scss'],
})
export class ScriptCommandComponent implements OnInit {
  @Input() commands!: ScriptCommand[];
  CommandType = CommandType;

  ngOnInit(): void {
    this.commands = structuredClone(this.commands).sort((a: ScriptCommand, b: ScriptCommand) =>
      a.order > b.order ? 1 : -1
    );
  }
}
