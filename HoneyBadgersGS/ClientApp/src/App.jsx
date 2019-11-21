import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Profile } from './components/Profile/profile.component';
import { friendList } from './components/Friend-List/friendList.component';
import { GameDetails } from './components/Game-Detail/gameDetails.component';
import { Cart } from './components/Cart/Cart';
import { ReviewForm } from './components/Review/review_write';


import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import './custom.css'
import { Wishlist } from './components/Wishlist/WishList';
import Checkout from './components/Cart/Checkout';
import Shipment from './components/Cart/Shipment';
import Order from './components/Cart/Orders';




export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route exact path='/gameDetail' component={GameDetails} />
        <Route path='/cart' component={Cart} />
        <Route exact path='/Details/:id' component={GameDetails} />
        <Route exact path='/Checkout' component={Checkout} />
        <Route exact path='/OrderCompleted' component={Order} />
        <Route exact path='/Profile' component={Profile} />
        <Route path='/Wishlist' component={Wishlist} />
        <Route path='/Shipment' component={Shipment} />
        <Route exact path='/friendList' component={friendList} />
        <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
      </Layout>
    );
  }
}
