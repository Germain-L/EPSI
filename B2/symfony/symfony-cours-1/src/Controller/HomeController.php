<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;

class HomeController extends AbstractController
{
    public function articles(): array
    {
        return [
            0 => [
                'title' => 'mon premier article',
                'text' => 'lorem ipsum',
                'author' => 'John Doe'
            ],
            1 => [
                'title' => 'mon deuxieme article',
                'text' => 'lorem ipsum',
                'author' => 'Matilda Doe'
            ]
        ];
    }


    /**
     * @Route("/home", name="home")
     */
    public function index(): Response
    {
        return $this->render('home/index.html.twig', [
            'controller_name' => 'HomeController',
        ]);
    }

    /**
     * @Route("/about", name="about")
     */
    public function about(): Response
    {
        return $this->render('home/about.html.twig');
    }

    /**
     * @Route("/article", name="article")
     */
    public function article(Request $request): Response
    {
        // http://www.example.com/article?id=1
        $param = $request->query->get('id');
        $id = (int)$param;

        if ($id <= 1) {
            $article = $this->articles()[$id];
            return $this->render('home/article.html.twig', [
                'article' => $article,
                'found' => true,
            ]);
        }

        return $this->render('home/article.html.twig', ['found' => false]);
    }
}
