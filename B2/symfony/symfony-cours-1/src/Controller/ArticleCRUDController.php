<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;


/**
 * Class ArticleCRUDController
 * package App/Controller
 * @Route("admin")
 */

class ArticleCRUDController extends AbstractController
{
    /**
     * @Route("admin/article/create", name="admin_article_create")
     */
    public function index(): Response
    {
        return $this->render('article_crud/index.html.twig', [
            'controller_name' => 'ArticleCRUDController',
        ]);
    }
}
