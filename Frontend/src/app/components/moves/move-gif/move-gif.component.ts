import { AfterViewInit, Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
import { SuperGif } from '@wizpanda/super-gif';
import { Move } from '@fightcore/models';

@Component({
  selector: 'app-move-gif',
  templateUrl: './move-gif.component.html',
  styleUrls: ['./move-gif.component.scss'],
})
export class MoveGifComponent implements AfterViewInit {
  @Input() move?: Move;
  @Input() characterName?: string;
  @ViewChild('moveImage') moveImage?: ElementRef;
  superGif?: SuperGif;
  gifLoadedError = false;

  ngAfterViewInit(): void {
    this.superGif = new SuperGif(this.moveImage!.nativeElement, {});
    this.superGif.load(() => {});
  }

  nextFrame(): void {
    this.superGif?.stepFrame(1);
  }

  previousFrame(): void {
    this.superGif?.stepFrame(-1);
  }

  onImageError(): void {
    this.gifLoadedError = true;
  }

  pauseGif(): void {
    if (this.superGif?.isPlaying()) {
      this.superGif?.pause();
    } else {
      this.superGif?.play();
    }
  }
}
