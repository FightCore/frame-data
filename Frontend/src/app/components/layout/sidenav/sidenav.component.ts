import { MediaMatcher } from '@angular/cdk/layout';
import { ChangeDetectorRef, Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { MatSidenav } from '@angular/material/sidenav';
import { NavigationEnd, NavigationStart, Router } from '@angular/router';
import { select, Store } from '@ngrx/store';
import { filter, tap } from 'rxjs';
import { updateTheme } from 'src/app/store/user-settings/user-settings.actions';
import { isDarkMode } from 'src/app/store/user-settings/user-settings.selectors';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.scss'],
})
export class SidenavComponent implements OnDestroy {
  @ViewChild('drawer') sidenav?: MatSidenav;
  mobileQuery: MediaQueryList;
  useDarkMode = false;
  private _mobileQueryListener: () => void;

  constructor(changeDetectorRef: ChangeDetectorRef, media: MediaMatcher, router: Router, private store: Store) {
    this.mobileQuery = media.matchMedia('(max-width: 600px)');
    this._mobileQueryListener = () => changeDetectorRef.detectChanges();
    this.mobileQuery.addListener(this._mobileQueryListener);

    router.events.pipe(filter((event) => event instanceof NavigationStart)).subscribe(() => {
      if (!this.sidenav || this.sidenav.mode !== 'over') {
        return;
      }

      this.sidenav.close();
    });

    this.store.pipe(select(isDarkMode())).subscribe((useDarkMode) => {
      this.useDarkMode = useDarkMode;
    });
  }

  ngOnDestroy(): void {
    this.mobileQuery.removeListener(this._mobileQueryListener);
  }

  onClickToggleTheme(): void {
    this.store.dispatch(updateTheme(!this.useDarkMode));
  }
}
