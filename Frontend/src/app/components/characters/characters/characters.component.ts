import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FrameDataCharacter } from 'src/app/models/framedata-character';
import { FrameDataService } from 'src/app/services/frame-data.service';

@Component({
  selector: 'app-characters',
  templateUrl: './characters.component.html',
  styleUrls: ['./characters.component.scss'],
})
export class CharactersComponent implements OnInit {
  characters?: FrameDataCharacter[];
  constructor(private frameDataService: FrameDataService) {}

  ngOnInit(): void {
    this.frameDataService.getCharacters().subscribe((characters) => {
      this.characters = characters;
    });
  }
}
