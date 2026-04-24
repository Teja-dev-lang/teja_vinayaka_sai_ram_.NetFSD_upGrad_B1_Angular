import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ToggleLogin } from './toggle-login';

describe('ToggleLogin', () => {
  let component: ToggleLogin;
  let fixture: ComponentFixture<ToggleLogin>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ToggleLogin],
    }).compileComponents();

    fixture = TestBed.createComponent(ToggleLogin);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
