import { Component } from '@angular/core';
import { PointerCommand } from 'src/app/models/commands/pointer-command';
import { CommandComponent } from '../command.component';

@Component({
  selector: 'app-pointer-command',
  templateUrl: './pointer-command.component.html',
  styleUrls: ['./pointer-command.component.scss'],
})
export class PointerCommandComponent extends CommandComponent<PointerCommand> {}
