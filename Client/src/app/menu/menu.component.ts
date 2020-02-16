import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { EventDetailsComponent } from "../event-details/event-details.component";
import { TabMenuModule } from "primeng/tabmenu";
import { MenuItem } from "primeng/api";
import { EventService, CommonService } from "../services";
import { EventDto, EventTypeDto } from "../models";

@Component({
  selector: "app-menu",
  templateUrl: "./menu.component.html",
  styleUrls: ["./menu.component.css"]
})
export class MenuComponent implements OnInit {
  eventList: EventDto[];
  constructor(
    private eventService: EventService,
    private commonService: CommonService,
    private router: Router
  ) {}

  async ngOnInit() {
    let _eventList: EventDto[] = await this.eventService
      .getEventsList(this.commonService.currentOwner.id)
      .toPromise();
    this.eventList = _eventList;

    let eventTypeList: EventTypeDto[] = await this.eventService
      .getEventTypes()
      .toPromise();
    this.commonService.eventTypes = eventTypeList;
  }
  changeEvent(_event: EventDto) {
    this.eventService.changeEvent(_event.id).subscribe((data: EventDto) => {
      this.commonService.currentEvent = data;
      // this.setFormGroupsValues();
      // this._cdr.detectChanges();
      this.commonService.flagToChangeEvent.next(true);
    });
  }
}
