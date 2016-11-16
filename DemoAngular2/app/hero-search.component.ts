﻿import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { Subject } from 'rxjs/Subject';
import * as model from '../clientapi/WebApiNG2ClientAuto';
import DemoWebApi_Controllers_Client = model.DemoWebApi_Controllers_Client;

@Component({
    moduleId: module.id,
    selector: 'hero-search',
    templateUrl: 'hero-search.component.html',
    styleUrls: ['hero-search.component.css'],
})
export class HeroSearchComponent implements OnInit {
    heroes: Observable<DemoWebApi_Controllers_Client.Hero[]>;
    private searchTerms = new Subject<string>();
    constructor(
        private heroSearchService: DemoWebApi_Controllers_Client.Heroes,
        private router: Router) { }
    // Push a search term into the observable stream.
    search(term: string): void {
        this.searchTerms.next(term);
    }
    ngOnInit(): void {
        this.heroes = this.searchTerms
            .debounceTime(300)        // wait for 300ms pause in events
            .distinctUntilChanged()   // ignore if next search term is same as previous
            .switchMap(term => term   // switch to new observable each time
                // return the http search observable
                ? this.heroSearchService.search(term)
                // or the observable of empty heroes if no search term
                : Observable.of<DemoWebApi_Controllers_Client.Hero[]>([]))
            .catch(error => {
                // TODO: real error handling
                console.log(error);
                return Observable.of<DemoWebApi_Controllers_Client.Hero[]>([]);
            });
    }
    gotoDetail(hero: DemoWebApi_Controllers_Client.Hero): void {
        let link = ['/detail', hero.id];
        this.router.navigate(link);
    }
}